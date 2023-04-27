using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtulaGenerators : MonoBehaviour {

    public GameObject[] virtuluSagataves;
    public float laikaIntervals = 1f;
    public float minX, maxX;
    private Transform krasnsTransform;


    void Start() {
        krasnsTransform = GetComponent<Transform>();
    }
    public void SagatavotVirtulus(bool stavoklis) {
        if (stavoklis == true)
            StartCoroutine(Generet());
        else
            StopAllCoroutines();
    }

    IEnumerator Generet() {
        while (true)
        {
            minX= krasnsTransform.position.x - 15;
            maxX= krasnsTransform.position.x + 15;
            var cipars = Random.Range(minX, maxX);
            var pozicija = new Vector2(cipars, transform.position.y);
            GameObject virtulis = Instantiate(virtuluSagataves[Random.Range(0, virtuluSagataves.Length)], pozicija, Quaternion.identity, krasnsTransform);
            yield return new WaitForSeconds(laikaIntervals);
        }
    
    }
}
