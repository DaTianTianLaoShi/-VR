using HutongGames.PlayMaker.Actions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript :MonoBehaviour
{
    // Start is called before the first frame update
    public event EventHandler<EventAdminChange> Eac;
    //事件发布程序
    public void Addlisteners(string GamrobjectPool) 
    {
        EventHandler<EventAdminChange> sss = Eac;
        if (sss!=null) 
        {
            sss(GamrobjectPool, new EventAdminChange());
        }
    }
    //事件监听程序
}
public class a:MonoBehaviour
{
    private void Start()
    {
        //Eac();
        NewBehaviourScript script = new NewBehaviourScript();
        a aa = new a();
        script.Eac += aa.Debugs;
        script.Addlisteners("666");
    }
    public void Debugs(object gameObject, EventAdminChange eventAdmin) 
    {
        Debug.Log("11111");
        //Debug.Log();
        // eventAdmin.se
        eventAdmin.IsAdmin = true;
        eventAdmin.OnEnter();
    }
} 
