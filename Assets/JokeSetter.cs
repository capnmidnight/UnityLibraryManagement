using TMPro;

using UnityEngine;

public class JokeSetter : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void OnValidate()
    {
        if(text == null)
        {
            text = GetComponent<TextMeshProUGUI>();
        }
    }

    public void NextJoke()
    {
        if(text != null)
        {
            text.SetText(ChuckNorris.Jokes.Next());
        }
    }
}
