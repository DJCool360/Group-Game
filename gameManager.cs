using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
  public static gameManager instance;

  [SerializeField] GameObject menuActive;
  [SerializeField] GameObject menuPause;
  [SerializeField] GameObject menuWin;
  [SerializeField] GameObject menuLose;

  [SerializeField] TMP_Text gameGoalCountText;

  public Image playerHPBar;

  public GameObject playerDamageFlash;

  public GameObject player;
  public playerController playerScript;
  public bool isPaused;

  float timeScaleOrgi;

  int gameGoalCount;

  void Awake()
  {
    instance = this;
    timeScaleOrgi = Time.timeScale;

    player = GameObject.FindWithTag("Player");
    playerScript = player.GetComponent<playerController>();
    playerSpawnPos = GameObject.FindWithTag("Player Spawn Pos");
  }

    // Update is called once per frame
    void Update()
    {
        
    }
}
