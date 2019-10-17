using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushButton : MonoBehaviour {

  Animator animation;
  public GameObject connectedDoor;

  void Start() {
    animation = GetComponent<Animator>();
  }

  void OnTriggerEnter(Collider other) {

    animation.SetBool("isOpen", true);
    connectedDoor.GetComponent<Animator>().SetBool("isOpenedDoor", true);

    if (transform.parent.gameObject.transform.Find("porteIsoloir") != null) {
      transform.parent.gameObject.transform.Find("porteIsoloir").transform.Translate(new Vector3(0.0f, 0.0f, 2.5f));
    }
    transform.parent.gameObject.transform.Find("porte").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
  }
}
