using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy2 : MonoBehaviour
{
    public int life;
    public UnityEvent EventDeath;

    public UnityEvent EvenOnDestroyed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life<1)
        {
            EventDeath?.Invoke();
        }

    }

    public void TakeHit()
    {
        life--;
    }

    private void OnDestroy()
    {
        EvenOnDestroyed?.Invoke();
    }
}
