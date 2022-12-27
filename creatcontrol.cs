using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creatcontrol : MonoBehaviour
{
    Vector3 v3v;
    public GameObject cube;
    public Transform createpoint;
    public Text xynumber;
    public Text createnumbertext;
    public int createnumber = 10;

    private void Update()
    {
        createnumbertext.text = "剩余搭建次数:" + createnumber;
        xynumber.text = "x:" + createpoint.position.x + "y:" + createpoint.position.y;
    }
    public void create()
    {
        if (createnumber > 0)
        {
            Instantiate(cube, createpoint.position, createpoint.rotation);
            createnumber -= 1;
        }
    }
    public void Xmore()
    {
        createpoint.Translate(1,0,0);
    }
    public void Xless()
    {
        createpoint.Translate(-1, 0, 0);
    }
    public void Ymore()
    {
        createpoint.Translate(0, 1, 0);
    }
    public void Yless()
    {
        createpoint.Translate(0, -1, 0);
    }
}
