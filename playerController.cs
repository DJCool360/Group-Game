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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
