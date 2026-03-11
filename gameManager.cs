using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
  public static gamemanager instance;

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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
