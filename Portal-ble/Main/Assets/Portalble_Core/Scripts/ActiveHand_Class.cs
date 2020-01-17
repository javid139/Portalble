﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Portalble;
using Portalble.Functions.Grab;

/* merge Portalble general controller and wsmanager.cs */
/* merge Grab.cs */
/* merge Grabbable.cs */


public class ActiveHand_Class : MonoBehaviour
{
    public Text t1;
    public Text t2;

    private void Start()
    {
        /* add event to the listener */
        Grab.Instance.OnRelease += new OnReleaseEvent(Release);
    }

    // Update is called once per frame
    // ActiveHandManager, ActiveHandGesture, ActivehandTransform
    void Update()
    {
        if (PortalbleGeneralController.main.ActiveHandManager != null)
        {
            Debug.Log(PortalbleGeneralController.main.ActiveHandManager);
        }
        if (PortalbleGeneralController.main.ActiveHandGesture != null)
        {
            Debug.Log(PortalbleGeneralController.main.ActiveHandGesture);
        }
        if (PortalbleGeneralController.main.ActiveHandTransform != null)
        {
            Debug.Log(PortalbleGeneralController.main.ActiveHandTransform.parent.name + "," + PortalbleGeneralController.main.ActiveHandTransform.name);
        }


    }

    /* make sure you follow the format, 
     *  Transform hand,
     *  Grabbable gobj */
    private void Release(Transform hand, Grabable gobj)
    {
        t2.text = "Triggered:" + hand.name + "," + gobj.name;
    }
}
