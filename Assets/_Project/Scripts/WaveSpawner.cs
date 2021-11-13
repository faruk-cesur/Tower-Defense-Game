using System;
using System.Collections;
using TMPro;
using UnityEngine;


public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWaves = 5.5f;
    public TextMeshProUGUI waveCountdownText;

    private float _countdown = 2f;
    private int _waveIndex = 0;
    private WaitForSeconds _spawnTimer;

    private void Awake()
    {
        _spawnTimer = new WaitForSeconds(0.5f);
    }

    private void Update()
    {
        if (_countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            _countdown = timeBetweenWaves;
        }

        _countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(_countdown).ToString();
    }

    private IEnumerator SpawnWave()
    {
        _waveIndex++;

        for (int i = 0; i < _waveIndex; i++)
        {
            SpawnEnemy();
            yield return _spawnTimer;
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}