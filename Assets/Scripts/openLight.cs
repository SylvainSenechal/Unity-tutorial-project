using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLight : MonoBehaviour {
    public Light myLight;
    public GameObject bossPrefab;


    void OnTriggerEnter(Collider other) {
      myLight.enabled = !myLight.enabled;
      GameObject boss = Instantiate<GameObject>(bossPrefab, new Vector3(-65f, 1f, 2.5f), this.transform.rotation) as GameObject;
      boss.GetComponent<deplacementEnnemi3>().target = GameObject.Find("personnage").transform;

    }
}
