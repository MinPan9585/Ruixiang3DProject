using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cube;
    public GameObject inGameBoard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CubeFall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CubeFall()
    {
        yield return new WaitForSeconds(2.5f);
        cube.SetActive(false);
        inGameBoard.SetActive(true);
    }
}
