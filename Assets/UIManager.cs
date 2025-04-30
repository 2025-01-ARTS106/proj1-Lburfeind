using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollision(Collision collision)
    {
        { SceneManager.LoadScene("Ending Scene"); }
    }
}