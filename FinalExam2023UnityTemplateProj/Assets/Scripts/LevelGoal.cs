using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGoal : MonoBehaviour
{
    [SerializeField]
    private string level_name = "MainMenu";

    [SerializeField]
    private float scene_load_delay = 1f;

    private void OnTriggerEnter(Collider other)
    {
        Invoke(nameof(Load), scene_load_delay);
    }

    private void Load()
    {
        SceneManager.LoadScene(level_name);
    }

}
