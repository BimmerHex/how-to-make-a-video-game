using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter() {
        gameManager.CompleteLevel();
    }
}
