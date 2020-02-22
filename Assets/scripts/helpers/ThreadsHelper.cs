using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Collections;
using System;

public static class ThreadsHelper
{
    public static IEnumerator WaitAndDo(float seconds, Action action)
    {
        yield return new WaitForSeconds(seconds);
        action();
    }
}