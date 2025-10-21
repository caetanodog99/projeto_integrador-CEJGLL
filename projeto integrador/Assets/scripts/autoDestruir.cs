using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class autoDestruir : MonoBehaviour
{
    public IEnumerator DestruirDepois()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }


    void Update()
    {
        DestruirDepois();
    }
}
