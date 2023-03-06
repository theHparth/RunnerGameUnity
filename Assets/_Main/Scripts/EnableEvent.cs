using System.Collections;
using System.Collections.Generic;
// https://github.com/theHparth/RunnerGameUnity/issues/2
using UnityEngine;
using UnityEngine.Events;
 
public class EnableEvent : MonoBehaviour
{
    // TODO: help
    public UnityEvent _Enable;
    [System.Serializable]
    public struct OnEnableHandler
    {
        public float Delete12345;       
        public float StartDelay;
        public UnityEvent Enable;
    }
// https://github.com/theHparth/RunnerGameUnity/issues/3 - 4567
    [Header ("OnEnable")]
    public OnEnableHandler[] EnableHandler;

    [Space]

    [Header ("OnDisable")]
    public UnityEvent Disable;

    private void OnEnable ()
    {
        _Enable.Invoke();
        StartCoroutine (EnableDelayCall ());
    }

    private void OnDisable ()
    {
        if (Disable != null)
        {
            Disable.Invoke ();
        }
    }

    IEnumerator EnableDelayCall ()
    {
        foreach (var item in EnableHandler)
        {
            yield return new WaitForSeconds (item.StartDelay);

            if (item.Enable != null)
                item.Enable.Invoke ();
        }

        yield return null;
    }

    public void DestroyObj(GameObject go)
    {
        Destroy(go);
    }

    public void DestroyItself()
    {
        Destroy(gameObject);
    }
}