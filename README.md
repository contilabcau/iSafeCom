# iSafeCom System Integration

This repository provides a comprehensive guide and resources related to the integration of specialized AI tools, including OpenAI's Whisper, ChatGPT, and Amazon Polly, as discussed in our research paper.

## Table of Contents

- [Overview](#overview)
- [System Architecture](#system-architecture)
- [Integration Process](#integration-process)
- [API Details](#api-details)
- [Configuration and Preprocessing](#configuration-and-preprocessing)
- [Sequence Diagram](#sequence-diagram)
- [Codebase](#codebase)
- [License](#license)

## Overview

The iSafeCom system leverages advanced AI tools to facilitate transcription, translation, and text-to-speech functionalities. This repository aims to provide clarity on the integration process, ensuring technological reproducibility.

## System Architecture

The system primarily integrates three tools:

1. **Whisper**: Developed by OpenAI, it transcribes and translates user voice inputs.
2. **ChatGPT**: Utilizes advanced NLP capabilities to generate appropriate responses.
3. **Amazon Polly**: Converts text responses into natural-sounding voice outputs.

## Integration Process

A detailed breakdown of the integration process is provided, showcasing the flow of data and interactions between the tools. The sequence diagram visually represents this flow, offering a clear understanding of the system's workings.

## API Details

- **Whisper API**: Used for transcription and translation functionalities.
- **ChatGPT API**: Handles text-based responses and interactions.
- **Amazon Polly API**: Manages text-to-speech conversion.

## Configuration and Preprocessing

Each tool requires specific configuration settings and preprocessing steps. These are elaborated upon in the respective sections, ensuring seamless integration.

- **Whisper**: Configuration settings are provided in `WhisperConfig.json`. Voice data undergoes specific formatting before processing.
- **ChatGPT**: Configuration is detailed in `ChatGPTConfig.json`.
- **Amazon Polly**: Audio data is formatted in WAV/MP3 for processing.

## Sequence Diagram

The sequence diagram provides a visual representation of the data flow and interactions between the integrated tools. It serves as a practical guide for understanding the system's architecture and functionalities.

[View the Sequence Diagram](link-to-diagram)

## Codebase

The repository contains the following C# scripts detailing the system's functionalities:

- **ChatGPT.cs**: Handles interactions with the ChatGPT API, managing text-based responses.
- **NpcDialog.cs**: Manages dialogues and interactions with NPCs (Non-Player Characters) within the game environment.
- **NpcInfo.cs**: Contains information and attributes related to NPCs.
- **TextToSpeech.cs**: Interfaces with Amazon Polly for text-to-speech conversion.
- **Whisper.cs**: Manages voice input transcription and translation using the Whisper tool.
- **WorldInfo.cs**: Contains information about the game world, including environmental details and world attributes.


## License

This work is licensed under a Creative Commons Attribution 4.0 International License. For more details, see the [LICENSE](LICENSE) file or visit [Creative Commons Attribution 4.0 International License](https://creativecommons.org/licenses/by/4.0/).
