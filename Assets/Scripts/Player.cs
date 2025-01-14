using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        // Initialize seeds
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        // Update the UI at the start
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        HandleMovement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }
     private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        _playerTransform.Translate(moveX, moveY, 0);
    }
    public void PlantSeed ()
    {
        if (_numSeedsLeft > 0)
        {
            // Create a plant at the player's position
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

            // Update seed counts
            _numSeedsLeft--;
            _numSeedsPlanted++;

            // Update the UI
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }
}
