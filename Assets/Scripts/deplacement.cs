using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour {
  public float moveSpeed = 5f;
  public float turnSpeed = 180f;

  void Update() {

    float yaw = Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
    // float pitch = - Input.GetAxis("Mouse Y");
    transform.Rotate(new Vector3(0.0f, yaw, 0.0f));

    if (Input.GetKey("up")) {
      transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    if (Input.GetKey("down")) {
      transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
    }


    if (Input.GetKey("left")) {
      transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
    if (Input.GetKey("right")) {
      transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    // if (Input.GetKey("left")) {
    //   transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
    // }
    // if (Input.GetKey("right")) {
    //   transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
    // }

    if (this.gameObject.transform.position.y < 0.3f) {
      this.GetComponent<healthPlayer>().takeDamage(20);
      this.gameObject.transform.position = new Vector3(-46f, 1f, 0f);
      this.gameObject.transform.eulerAngles = new Vector3(0f, -90f, 0f);
    }
  }

  void OnTriggerEnter(Collider other) {
    Debug.Log(other);
    if (other.gameObject.CompareTag("health")) {
      Destroy(other.gameObject);
      this.GetComponent<healthPlayer>().gainHeal(20);
    }
  }

}
