using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> RemovedCarddeck = new List<Card>();
    public Transform[] cardslot;  // to show cards in hands //
    public bool[] availableCardslots;

    public Text deckSizeText;
    public Text removedCardsText;
    public Card randomCard;


    public Card cd;
  
   


    [SerializeField] private GameObject selectioncard;
    private GameObject newselection;

    private bool isSelected;

    public bool hasBeenPlayed;
    public int handIndex;



    private void Start()
    {
        

    }


 
       
     

    public void ADD()
    {

        if (deck.Count >= 1)
        {
            randomCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardslots.Length; i++)
            {
                if (availableCardslots[i] == true)
                {
                    randomCard.gameObject.SetActive(true);
                    handIndex = i;
                   
                    randomCard.transform.position =cardslot[i].position;    
                    hasBeenPlayed = false;
                    availableCardslots[i] = false;
                    deck.Remove(randomCard);
                    return;
                }


            }


        }
    }



    public void Shuffle()
    {
        if (RemovedCarddeck.Count > 1)
        {
            foreach (Card card in RemovedCarddeck)
            {
                deck.Add(card);
            }
            RemovedCarddeck.Clear();
        }
    }

    public void RemovedCards()
    {
        if(Input.GetMouseButtonDown(0))
        {   
            RemovedCarddeck.Add(GameObject.FindObjectOfType<Card>());
           
            gameObject.SetActive(false);
        }
       
    }


    public void DrawCard()
    {
        

        /*
            if (hasBeenPlayed == false)
            {
               
                randomCard.transform.position += Vector3.up * 2;
                hasBeenPlayed = true;
                availableCardslots[handIndex] = true;
        
         */   
    }



     private void Update()
    {
       
        deckSizeText.text = deck.Count.ToString();
        removedCardsText.text = RemovedCarddeck.Count.ToString();
    }



}

