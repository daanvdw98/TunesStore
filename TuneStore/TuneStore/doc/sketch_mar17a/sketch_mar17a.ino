
/*
 * Bike light revision 3: blinky
 */

int led1Pin = 12;
int led2Pin = 11;
int led3Pin = 10;
int led4Pin = 9;
int led5Pin = 8;

int switchPin = 2;

int val;                            // variable for reading the pin status
int val2;                           // variable for reading the delayed/debounced status
int buttonState;                    // variable to hold the button state
int lightMode = 0;

void setup()                        
{
  pinMode(switchPin, INPUT);        // Set the switch pin as input

  pinMode(led1Pin, OUTPUT);
  pinMode(led2Pin, OUTPUT);
  pinMode(led3Pin, OUTPUT);
  pinMode(led4Pin, OUTPUT);
  pinMode(led5Pin, OUTPUT);

  Serial.begin(9600);               // Set up serial communication at 9600 bps
  buttonState = digitalRead(switchPin);  // read the initial state

  Serial.print("LightMode is: ");
  Serial.println(lightMode);
}

void loop()                      
{
  val = digitalRead(switchPin);     // read input value and store it in val
  delay(10);                        // 10 miliseconds is a good ammount of time
  val2 = digitalRead(switchPin);    // read the input again to check for bounces
  if(val == val2)                   // make sure we got 2 consistant readings!
  {
    if(val != buttonState)            // check button state is changed!
    {
      if(val == LOW)                  // check if the button is pressed
      {
        lightMode++;
        if(lightMode == 4)
        {
          lightMode = 0;
        }
        Serial.print("LightMode is: ");
        Serial.println(lightMode);
      }
    }
    buttonState = val;                // save the new state in our variable
  }

  if(lightMode == 0)
  {
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, LOW);
    digitalWrite(led5Pin, LOW);
  }
  if(lightMode == 1)
  {
    digitalWrite(led1Pin, HIGH);
    digitalWrite(led2Pin, HIGH);
    digitalWrite(led3Pin, HIGH);
    digitalWrite(led4Pin, HIGH);
    digitalWrite(led5Pin, HIGH);
  }
  if(lightMode == 2)            // let them blink
  {
    digitalWrite(led1Pin, HIGH);
    digitalWrite(led2Pin, HIGH);
    digitalWrite(led3Pin, HIGH);
    digitalWrite(led4Pin, HIGH);
    digitalWrite(led5Pin, HIGH);
    delay(100);
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, LOW);
    digitalWrite(led5Pin, LOW);
    delay(100);
  }
  if(lightMode == 3)
  {
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, LOW);
    digitalWrite(led5Pin, LOW);
    delay(60);
    digitalWrite(led1Pin, HIGH);
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, LOW);
    digitalWrite(led5Pin, LOW);
    delay(60);
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, HIGH);
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, LOW);
    digitalWrite(led5Pin, LOW);
    delay(60);
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, HIGH);
    digitalWrite(led4Pin, LOW);
    digitalWrite(led5Pin, LOW);
    delay(60);
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, HIGH);
    digitalWrite(led5Pin, LOW);
    delay(60);
    digitalWrite(led1Pin, LOW);
    digitalWrite(led2Pin, LOW);
    digitalWrite(led3Pin, LOW);
    digitalWrite(led4Pin, LOW);
    digitalWrite(led5Pin, HIGH);
    delay(60);
  }
  // if lightMode is 0, we don't have to do anything because the LEDs are allready off!
}



