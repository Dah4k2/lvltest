using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSiren : MonoBehaviour
{
    public GameObject RedLight, BlueLight;
    public float waitTime = .2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Siren());
    }

   
    IEnumerator Siren()
    {
        yield return new WaitForSeconds(waitTime);

        RedLight.SetActive(false);
        BlueLight.SetActive(true);

        yield return new WaitForSeconds(waitTime);

        RedLight.SetActive(true);
        BlueLight.SetActive(false);
        StartCoroutine(Siren());

    }
}
