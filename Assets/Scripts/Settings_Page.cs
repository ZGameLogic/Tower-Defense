using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings_Page : MonoBehaviour
{
   public void OnBackClicked()
   {
      SceneManager.LoadScene("Main Menu");
   }
}
