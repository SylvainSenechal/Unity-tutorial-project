using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacementEnnemi3 : MonoBehaviour {
  public float moveSpeed = 1f;
  public Transform target;
  public float speed = 10f;

  void Update() {

    Vector3 targetDir = target.position - transform.position;

    float step = speed * Time.deltaTime;
    Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
    transform.rotation = Quaternion.LookRotation(newDir);

    if (Vector3.Distance(transform.position, target.position) < 12f) {
      transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
  }
}
