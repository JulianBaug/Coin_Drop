using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    PolygonCollider2D pc;
    public PolygonCollider2D coin;
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pc.IsTouching(coin))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
