using UnityEngine;
using System.Collections;

public class autoDestruir : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestruirDepois());
    }

    IEnumerator DestruirDepois()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}