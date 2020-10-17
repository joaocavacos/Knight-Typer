using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Player playerScript;
    public Enemy enemy;
    public Timer timer;
    public InputToKill itK;
    
    void Update()
    {
       /* if (Player.player.hpSlider.value <= 0)
        {
            SceneManager.LoadScene("GameOver Screen");
        }
        
        */
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay Scene");
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
