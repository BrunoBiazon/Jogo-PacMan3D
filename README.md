# Pac-Man 3D 

Um jogo de labirinto em primeira pessoa inspirado no clássico Atari Pac-Man. O projeto foca em mecânicas de perseguição de IA, gerenciamento de estados de jogo e design de interface (UI) imersivo.

#  𔓎𔓎𔓎𔓎 ⍩⃝

## 🕹️ Mecânicas Principais
* **Movimentação:** Sistema de movimentação em primeira pessoa com `CharacterController`.
* **IA dos Fantasmas:** NPCs baseados em *NavMeshAgent* com dois estados: patrulha por waypoints e perseguição ao jogador.
* **Sistema de Coleta:** Pellets colecionáveis com sistema de pontuação e reset automático ao coletar todas.
* **PowerUp:** Ao consumir o ghost entre em modo de vulnerabilidade que altera a cor e a velocidade dos inimigos por tempo determinado.
* **Sistema de Vidas:** Gestão de progresso e controle de tentativas do jogador via `GameManager`.
* **Imersão:** Áudio reativo que responde à proximidade dos NPCs. Sirene quando houver perseguição, gamestart, sons de coleta, som quando os fanstamas ficarem vuneráveis.

## 📷 Imagens na Unity
### Visão geral da Cena do jogo
<img width="1470" height="920" alt="image" src="https://github.com/user-attachments/assets/173094b9-e2c0-4630-8a57-64e2d7905d84" />

### Mapa
<img width="1470" height="920" alt="image" src="https://github.com/user-attachments/assets/fa687b32-c9d8-446c-bf43-4d1097d5a7e2" />

## Scripts principais
* `scriptPC.cs`: Script do jogador. Responsável pela movimentação, câmera em primeira pessoa e detecção de colisões.
* `scriptGhost.cs`: Script dos fantamas inimigos, Controla a IA dos inimigos, estados de patrulha, perseguição e vulnerabilidade.
* `scriptGameManager.cs`: Gerenciador de placar, contagem de vidas e o ciclo de vida do jogo.

# Assets utilizados
* Chomp Man - Kit de Jogo 3D e Tutorial: https://assetstore.unity.com/packages/templates/tutorials/chomp-man-3d-game-kit-tutorial-174982?srsltid=AfmBOorLb4F1DuY-KnRkjzbpy1-lnYv4YQiJ1PTkdF5uEOUU4_vj-TIs

## Tecnologias Utilizadas
* **Engine:** Unity 6.3LTS
* **Linguagem:** C#

  
## 🎓 Sobre o Trabalho
Este projeto foi desenvolvido para disciplina **EC48N - Desenvolvimento de Jogos - C81 (2026_01)** na UTFPR. O foco foi aplicar conceitos de lógica de programação e Unity, desenvolvendo um jogo 3D em primeira pessoa.



