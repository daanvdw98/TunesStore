int led1Pin = 12;
int led2Pin = 11;
int led3Pin = 10;
int led4Pin = 9;
int led5Pin = 8;

int switchPin = 2;

int val;
int buttonState;
int lightMode = 0;

void setup() 
{
  pinMode(switchPin, INPUT);        

  pinMode(led1Pin, OUTPUT);
  pinMode(led2Pin, OUTPUT);
  pinMode(led3Pin, OUTPUT);
  pinMode(led4Pin, OUTPUT);
  pinMode(led5Pin, OUTPUT);
  
    Serial.begin(9600);               
  buttonState = digitalRead(switchPin);  
}


void loop() 
{
   val = digitalRead(switchPin);     // read input value and store it in val

  if(val != buttonState)            // check button state is changed!
  {
    if(val == LOW)                  // check if the button is pressed
    {
      if(lightMode == 0)
      {
        lightMode = 1;
        digitalWrite(led1Pin, HIGH);
        digitalWrite(led2Pin, HIGH);
        digitalWrite(led3Pin, HIGH);
        digitalWrite(led4Pin, HIGH);
        digitalWrite(led5Pin, HIGH);
      }
      else
      {
        lightMode = 0;
        digitalWrite(led1Pin, LOW);
        digitalWrite(led2Pin, LOW);
        digitalWrite(led3Pin, LOW);
        digitalWrite(led4Pin, LOW);
        digitalWrite(led5Pin, LOW);
      }
    }
  }
  buttonState = val;                // save the new state in our variable

}
