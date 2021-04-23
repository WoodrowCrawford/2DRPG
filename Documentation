Bullet Behavior: 

Variables: 

    Rigidbody: used to give physics to the object 

    Damage: how much damage the bullet will do 

    Despam time: how long it takes for the bullet to disappear. Modify this value to change how long it takes for it to disappear. 

Functions: 

    Rigidbody: returns a value for rigidbody 

    Damage: returns a value for damage 

    Awake: sets the rigidbody to a component of rigidbody 

    Start: destroys the bullet within a certain amount of time 

    OnTriggerEnter: If the bullet touches on Enemy, this function gets the enemy’s health and subtract it by the bullet’s damage. 

Enemy Attack Behavior: 

Variables: 

    Damage: how much damage the enemy will deal. Can be modified. 

    Movement: Gets a reference to the reference to the enemy movement behavior 

Functions:  

    Awake: Sets movement to the component of the enemy movement behavior 

    OnCollisionEnter: what happens when the Enemy touches the player 

Gun Behavior: 

Variables: 

    Bullet: a gaimeObject variable used as a reference 

Functions: 

    Fire: creates a bullet at a given position and adds a force to it in a given direction 

Health Behavior: 

Variables: 

    Rigidbody: Used to give physics to the object  

    Target: sets a target for the enemy 

    despawnTime: the amount of time it takes for the enemy to disappear 

Functions: 

    Target: returns a value for target 

    Start: sets the rigidbody to be the component of rigidbody 

    FixedUpdate: If the target is false, return 

PlayerShoot Behavior: 

Variables: 

    Gun: gets a reference of the GunBehavior  

    Shotspeed: determines how fast the bullet will travel 

Functions: 

    Update: used to get input from the player. Used to shoot a bullet from the gun 

SpawnBehavior: 

Variables: 

    SpawnObject: the gunObject that will be spawned  

    TimeBetweenSpawns: how long it will take before another object is spawned 

    Canspawn: used to check if the object can spawn or not 

Functions: 

    Start: used to start spawning objects 

    SpawnObjects: a function that can spawn a given object at different intervals while “canspawn” is true 

Movement: 

EnemyMovementBehavior: 

Variables: 

    Rigidbody: used to give physics to the object 

    Target: sets a target for the enemy 

    DespawnTime: The amount of time it takes for the enemy to disappear 

Functions: 

    Target: returns a value for the target 

    Start: sets the rigidbody to be the component of rigidbody and destroys the object when a certain amount of time has passed 

    FixedUpdates: if target is null, return 

PlayerMovementBehavior: 

Variables: 

    Movespeed: how fast the player will move. Can be modified. 

    Camera: gets a reference of the camera 

    Rigidbody: used to give physics to the object 

    Distance: the distance the player will be from the mouse. Increase it for it to be further and decrease it to make it closer to the screen. 

Functions: 

    Start: sets the rigidbody to be the component of rigidbody and makes the mouse curser not visible 

    Update: sets the vector 3 mouse position to be the input of the mouse and sets it to the screen 

UI: 

TimerBehavior: 

Variables: 

    timerText: A text used to store the timer text 

    StartTime: How long the application has been started 

Functions: 

    Start: sets StartTime to be Time.time 

    Update: this is used to create a timer that counts upward in minutes and seconds 
