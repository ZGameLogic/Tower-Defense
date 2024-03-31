using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button_Clicked : MonoBehaviour
{
   public void OnPlayGameClicked()
   {
      print("Play game Clicked");
   }

   public void OnSettingsClicked()
   {
      SceneManager.LoadScene("Settings");
   }

   public void OnQuitGameClicked()
   {
      Application.Quit();
   }
}
