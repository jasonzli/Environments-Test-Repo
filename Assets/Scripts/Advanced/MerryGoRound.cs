//Library includes with using
//Analogous to html's <script src="libraryname.js">
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class declaration with name and inheritance
//Name is referenced by other scripts
//Monobehavior is the Unity class for objects
public class MerryGoRound : MonoBehaviour
{
    
    //public -fields-
    public List<GameObject> SeatPrefabs = new List<GameObject>();
    public int NumberOfSeats = 4;
    public Vector3 RotationAmount = new Vector3();

    private int num;
    private bool truth;
    private string name;
    
    public List<GameObject> _Seats = new List<GameObject>();
    
    //private members
    //private List<GameObject> _Seats = new List<GameObject>();

    void Awake()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //fill our list of seats with a bunch of GameObjects
        _Seats = RandomSeatsFromPrefabs(NumberOfSeats, SeatPrefabs);
    }

    List<GameObject> RandomSeatsFromPrefabs(int numOfSeats,List<GameObject> seatPrefabs)
    {
        List<GameObject> newSeats = new List<GameObject>();
        for (var i = 0; i < numOfSeats; i++)
        {
            //create a GameObject with Instantiate
            
            //get a random object, demonstrating a function
            var randomSeatObject = RandomSeat(seatPrefabs);
            
            //Use Instaniate to create *instances*
            //var newSeat = Instantiate(randomSeatObject);
            
            
            //with rotated position, but not oriented
            var angle = (float) i / numOfSeats * Mathf.PI * 2f;
            var translationOffset = new Vector3(10f * Mathf.Sin(angle), 0f, 10f * Mathf.Cos(angle)); 
            //orientation
            var orientation = Quaternion.AngleAxis((float)i / numOfSeats * 360f, Vector3.up);
            var newSeat = Instantiate(randomSeatObject, transform.position + translationOffset, orientation, transform);
            
            
            newSeats.Add(newSeat);
        }

        return newSeats;
    }

    GameObject RandomSeat(List<GameObject> listofSeatObjects)
    {
        int randomIndex = Random.Range(0, listofSeatObjects.Count);
        return listofSeatObjects[randomIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
        Rotate(); //rotate the self
        MoveSeats(); //Move the Seats
    }

    void Rotate()
    {
        transform.Rotate(RotationAmount);
    }

    void MoveSeats()
    {
        //go through all the seats that we have
        for (int i = 0; i < _Seats.Count; i++)
        {
            //get the seat
            GameObject seat = _Seats[i];
            float yOffset = 0f;
            
            //set yOffset based on index value and time
            yOffset = Mathf.Sin((float) i * .65f + Time.frameCount * .02f);
            
            //create a variable for the new position with the offset
            Vector3 newPosition = seat.transform.localPosition; //get the current *local* position
            newPosition.y = yOffset; //only change the y

            seat.transform.localPosition = newPosition; //set the local position (as a child);
        }
    }
}
