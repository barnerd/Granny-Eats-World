using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public Image blackScreen;
    [Range(0, 1)]
    public float fadeSpeed;
    public float blackoutPauseLength;

    public IEnumerator FadeOut(Action _callback = null, bool _fadeIn = true)
    {
        Color _color = blackScreen.color;
        for (float alpha = 0f; alpha <= 1f; alpha += fadeSpeed)
        {
            _color.a = alpha;
            blackScreen.color = _color;
            yield return null;
        }

        // callback
        _callback?.Invoke();

        // delay time before fading back in
        yield return new WaitForSeconds(blackoutPauseLength);

        // fade back in
        if (_fadeIn) StartCoroutine(FadeIn());
    }

    public IEnumerator FadeIn()
    {
        Color _color = blackScreen.color;
        for (float alpha = 1f; alpha >= 0f; alpha -= fadeSpeed)
        {
            _color.a = alpha;
            blackScreen.color = _color;
            yield return null;
        }
    }
}
