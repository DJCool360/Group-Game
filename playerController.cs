using UnityEngine;

public class playerController : MonoBehaviour
{
  [SerializeField] playerController controller;
  [SerializeField] LayerMask ignoreLayer;

  [SerializeField] int HP;
  [SerializeField] int speed;
  [SerializeField] int sprintMod;
  [SerializeField] int jumpSpeed;
  [SerializeField] int jumpMax;
  [SerializeField] int gravity;

  [SerializeField] List<gunStats> gunList = new List<gunStats>();
  [SerializeField] GameObject gunModel;

  [SerializeField] int shootDamage;
  [SerializeField] int shootDist;
  [SerializeField] float shootRate;

  int jumpCount;
  int HPOrig;
  int gunListPos;
  float shootTimer;

  Vector3 moveDir;
  Vector3 playerVel;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    HPOrig = HP;
    updatePlayerUI();
  }

  // Update is called once per frame
  void Update()
  {
    movement();
    sprint();
  }

  public void spawnPlayer()
  {
    controller.transform.position = gamemanager.instance.playerSpawnPos.transform.position;
    Physics.SyncTransforms();
    HP = HPOrig;
    updatePlayerUI();
  }

  void movement()
  {
    shootTimer += Time.deltaTime;
    Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * shootDist, Color.red);

    if (controller.isGrounded)
    {
      jumpCount = 0;
      playerVel = Vector3.zero;
    }

    //moveDir = new Vector3(Input.GetAxis("Horizontal") 0, Input.GetAxis("Vertical"));
    moveDir = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
    controller.Move(moveDir * speed * Time.deltaTime);

    jump();
    controller.Move(playerVel * Time.deltaTime);
    playerVel.y -= gravity * Time.deltaTime;
    if (Input.GetButton("Fire1") && gunList.Count > 0 && gunList[gunListPos].ammoCur > 0 && shootTimer >= shootRate)
      shoot();
      selectGun();
      reload();
  }

}
