using System.Collections;
using UnityEngine;

public class DelayDisable : MonoBehaviour
{
    public float delay;

    private void OnEnable()
    {
        StartCoroutine(DisableAfter(delay));
    }

    IEnumerator DisableAfter(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(false);
    }
}
