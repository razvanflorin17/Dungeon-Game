using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText
{
    public bool active;
    public GameObject go;
    public Text txt;
    public Vector3 motion;
    public float duration;
    public float lastShown;

    public void Show()
    {
        active = true;
        lastShown = Time.time;
        go.SetActive(active);

    }

    public void Hide()
    {
        active = false;
        go.SetActive(active);
    }

    public void UpdateFloationgText()
    {
        if (!active) // daca este inactiv, return
            return;

        if (Time.time - lastShown > duration) // fct pt a ne asigura ca am afisat destul tp
            Hide();
        go.transform.position += motion * Time.deltaTime;
    }
}
