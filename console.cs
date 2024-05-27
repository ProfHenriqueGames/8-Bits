/*/um esquema básico usando um microcontrolador Arduino Uno, 
um botão como entrada e um LED como saída. 
Este circuito acenderá o 
LED quando o botão for pressionado.

Componentes necessários:

Arduino Uno
Resistor de 220 ohms
LED
Botão
Protoboard
Jumpers (fios)
/*/
=====

          Arduino Uno
        +-------------+
        |             |
        |     5V o----+----o VCC do LED
        |             |
        |    D2 o-----+----o Terminal do botão
        |             |
        |   GND o-----+----o Terminal do resistor
        |             |
        +-------------+----o GND do LED

============

const int buttonPin = 2; // Pino digital onde o botão está conectado
const int ledPin = 13;   // Pino digital onde o LED está conectado

int buttonState = 0;     // Variável para armazenar o estado do botão

void setup() {
  pinMode(ledPin, OUTPUT);      // Define o pino do LED como saída
  pinMode(buttonPin, INPUT);    // Define o pino do botão como entrada
}

void loop() {
  buttonState = digitalRead(buttonPin); // Lê o estado do botão

  // Se o botão estiver pressionado (estado baixo), acenda o LED
  if (buttonState == LOW) {
    digitalWrite(ledPin, HIGH);
  } else {
    digitalWrite(ledPin, LOW); // Caso contrário, desligue o LED
  }
}
============
/*/
Explanação

Este código fará com que o LED conectado ao pino 13 
do Arduino acenda quando o botão conectado 
ao pino 2 for pressionado. Certifique-se de que o botão 
esteja conectado entre o pino 2 e o GND, 
e o resistor de 220 ohms esteja conectado entre 
o pino 2 e o pino 5V do Arduino.
