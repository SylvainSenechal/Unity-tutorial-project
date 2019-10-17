using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour {
  public void replayGame() {
    Debug.Log("playing again");
    SceneManager.LoadScene("SampleScene");
  }
}
