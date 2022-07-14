using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource ForestDay;
    public AudioSource ForestNight;
    public AudioSource Cave;
    public AudioSource[] Shimmers;
    public AudioSource[] Torches;
    
    bool inCave = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (inCave) {
            inCave = false;
            ForestDay.volume = 1f;
            ForestNight.volume = 1f;
            Cave.volume = 0f;
            foreach(var shimmer in Shimmers)
            {
                shimmer.volume = 0f;
            }
            foreach(var torch in Torches)
            {
                torch.volume = 0f;
            }
        }
        else
        {
            inCave = true;
            ForestDay.volume = 0.1f;
            ForestNight.volume = 0.1f;
            Cave.volume = 1f;
            foreach (var shimmer in Shimmers)
            {
                shimmer.volume = 0.75f;
            }
            foreach (var torch in Torches)
            {
                torch.volume = 0.75f;
            }
        }
    }
}
