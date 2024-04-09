using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISupport : MonoBehaviour
{
    [SerializeField] private List<GameObject> fighters = new List<GameObject>(); //fighter
    public List<GameObject> Fighters { get { return fighters; } }

    [SerializeField] private List<GameObject> builders = new List<GameObject>(); //builder
    public List<GameObject> Builders { get { return builders; } }

    [SerializeField] private List<GameObject> workers = new List<GameObject>(); //worker
    public List<GameObject> Workers { get { return workers; } }

    [SerializeField] private List<GameObject> hq = new List<GameObject>();
    public List<GameObject> HQ { get { return hq; } }
    
    [SerializeField] private List<GameObject> houses = new List<GameObject>();
    public List<GameObject> Houses { get { return houses; } }
    
    [SerializeField] private List<GameObject> barracks = new List<GameObject>();
    public List<GameObject> Barracks { get { return barracks; } }

    [SerializeField] private Faction faction;
    public Faction Faction { get { return faction; } }
    
    // Start is called before the first frame update
    void Awake()
    {
        faction = GetComponent<Faction>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Refresh()
    {
        fighters.Clear();
        workers.Clear();
        builders.Clear();

        foreach (Unit u in faction.AliveUnits)
        hq.Clear();
        houses.Clear();
        barracks.Clear();

        foreach (Building b in faction.AliveBuildings)
        {
            if (b == null)
                continue;
            
            if (b.IsHQ)
                hq.Add(b.gameObject);
            
            if (b.IsHousing) 
                houses.Add(b.gameObject);

            if (b.IsBarrack) 
                barracks.Add(b.gameObject);
        }
    }
    

}
