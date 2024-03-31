using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Button_Clicked : MonoBehaviour
{
   public void OnPlayGameClicked()
   {
      print("Play game Clicked");
   }

   public void OnSettingsClicked()
   {
      print("Settings Clicked");
   }

   public void OnQuitGameClicked()
   {
      Application.Quit();
   }
}
