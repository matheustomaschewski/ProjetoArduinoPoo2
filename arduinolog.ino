const int analog_pin = A1;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  delay(100);
}

void loop() {
  // put your main code here, to run repeatedly:
  unsigned int analog_val = 0;
  analog_val = analogRead(analog_pin);
  Serial.println(analog_val);
  delay(100);
}
