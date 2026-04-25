using System;
using Events;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UI
{
    public class UIRandomLetter : MonoBehaviour
    {
        [SerializeField] private TMP_Text _letterHolder;

        private readonly char[] RandomLetters = new[] {'1', '2', '3', '4', '5', '6', '7', '8', '9',  'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M'};
        
        private void Awake()
        {
            PublisherSubscriber.Subscribe<RandomLetterEvent>(OnRandomLetterEvent);
        }

        private void OnDestroy()
        {
            PublisherSubscriber.Unsubscribe<RandomLetterEvent>(OnRandomLetterEvent);
        }

        private void OnRandomLetterEvent(RandomLetterEvent obj)
        {
            _letterHolder.text = RandomLetters[Random.Range(0, RandomLetters.Length)].ToString();
        }
    }
}