using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;
using System;

public class AnalyticsDemo : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        await UnityServices.InitializeAsync();

        AnalyticsService.Instance.StartDataCollection();

        TestEvent();
    }

    private void TestEvent()
    {
        CustomEvent myEvent = new CustomEvent("MyEvent")
        {
            { "fabulousString", "woah!" },
            { "peculiarBool", true },
            { "sparklingInt", 1337 },
            { "spectacularFloat", 313.37f }
        };

        AnalyticsService.Instance.RecordEvent(myEvent);
    }

}

