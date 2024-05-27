/*/código em C++ para Arduino Nano que faz um LED piscar 
em um intervalo regular de tempo: /*/

// Define o pino ao qual o LED está conectado
const int ledPin = 13;

void setup() {
  // Configura o pino do LED como saída
  pinMode(ledPin, OUTPUT);
}

void loop() {
  // Liga o LED
  digitalWrite(ledPin, HIGH);
  // Aguarda 1 segundo
  delay(1000);
  // Desliga o LED
  digitalWrite(ledPin, LOW);
  // Aguarda mais 1 segundo
  delay(1000);
}

/*/
código faz com que o LED conectado ao pino 13 pisque a cada segundo 
(ligando e desligando alternadamente). 
Certifique-se de conectar o LED ao pino 13 do Arduino Nano
/*/