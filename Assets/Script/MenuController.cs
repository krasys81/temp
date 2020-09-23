using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    private static Logger logger;

    // Start is called before the first frame update
    void Start()
    {
        ObjectFactory factory = ObjectFactory.GetInstance();
        logger = factory.GetLogger();
    }

    void Update()
    {

    }
    

    public void ClickStart()
    {
        logger.Log("ClickStart");
    }

    public void ClickOption()
    {
        logger.Log("ClickOption");
    }

    public void ClickQuit()
    {
        logger.Log("ClickQuit");
        Application.Quit();
    }
}
