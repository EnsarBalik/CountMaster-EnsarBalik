using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameManager gm;
    [SerializeField] private GameObject successPanel;

    private void OnTriggerEnter(Collider other)
    {
        successPanel.SetActive(true);
        gm.gameStart = false;
        Time.timeScale = 0.5f;
    }
}
