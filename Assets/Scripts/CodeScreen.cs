using UnityEngine;

public class CodeScreen : MonoBehaviour
{
    public GameObject codeCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        codeCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Display()
    {
        codeCanvas.SetActive(true);
    }
}
