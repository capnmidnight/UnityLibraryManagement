using TMPro;

using UnityEngine;

namespace ChuckNorris
{
    public class JokeSetter : MonoBehaviour
    {
        public TextMeshProUGUI text;
        private ChuckNorris client;

        private void OnValidate()
        {
            if (text == null)
            {
                text = GetComponent<TextMeshProUGUI>();
            }
        }

        private void Awake()
        {
            client = new ChuckNorris();
        }

        public void NextJoke()
        {
            if (text != null)
            {
                text.SetText(client.GetRandom().value);
            }
        }
    }

}