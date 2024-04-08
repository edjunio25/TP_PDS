## TP_PDS
# Repositório para o trabalho prático da disciplina Prática em Desenvolvimento de Software - 01/2024

# **Participantes**:
- **Edson Júnio Bonfim Pinto** - *backend*;

- **Luiz Henrique Silveira Barcelos** - *fullstack*;

- **Vinicius Gabriel de Carvalho** - *fullstack*;

- **Willian Douglas Brito Braga** - *backend*;

# **Escopo de projeto**:

- Objetivo geral: desenvolver um sistema  de organização escolar privada para estudantes.

- Motivação: cada estudante tem sua forma de se organizar, e as plataformas escolares e universitárias geralmente não proveem recursos ou dados atualizados o suficiente para tal, portanto faz-se necessária uma plataforma pessoal para organização, inteiramente controlada pelo usuário.

# **Principais features**:
- Gestão de notas e faltas por semestre;

- Gestão de materiais (arquivos pdf, fotos, arquivos de texto, etc) por disciplina;

- Gestão de calendário, com rotina diária de disciplinas e estudos, além de eventos isolados (provas, trabalhos, etc)


# **Linguagens**:
- C#

- Angular

# **Tecnologias**:
- SQLite

- *Mais opções podem ser adicionadas conforme o avanço do projeto*;

# **Backlog**

### **História #1: Como usuário, eu gostaria de cadastrar uma conta na plataforma e tê-la registrada no sistema** <br />
Tarefas e responsáveis:
- Criar o projeto em Angular [Luiz]
- Designar a página de cadastro [Vinicius]
- Implementar um banco de dados com a primeira entidade (usuário) [Willian]
- Determinar o endpoint de cadastro de email e senha [Edson]
- Determinar o endpoint de login de usuário [Willian]
<br />

### **História #2: Como usuário, eu gostaria de organizar minha vida acadêmica por semestres** <br />
Tarefas e responsáveis:
- Adicionar nova entidade (semestre) ao banco de dados [Luiz]
<br />

### **História #3: Como usuário, eu gostaria de adicionar/remover(arquivar) semestres no sistema** <br />
Tarefas e responsáveis:
- Criar botão + modal de cadastro de semestre [Vinicius]
- Determinar o endpoint de cadastro de semestre [Edson]
- Criar botão + modal de arquivamento de semestre [Vinicius]
- Determinar o endpoint de arquivamento de semestre [Willian]
<br />

### **História #4: Como usuário, eu gostaria de organizar os semestres em função das disciplinas matriculadas** <br />
Tarefas e Responsáveis:
- Acionar nova entidade (disciplina) ao banco de dados [Willian]
- Criar botão + modal de cadastro de semestre [Vinicius]
- Criar endpoint de cadastro de semestre [Edson]

<br />

### **História #5: Como usuário, eu gostaria de adicionar/remover disciplinas nos semestres registrados** <br />
Tarefas e Responsáveis:
- Criar botão + modal de criação de disciplina em um semestre [Luiz]
- Determinar endpoint de cadastro da disciplina [Edson]
- Criar botão + modal de remoção de disciplina em um semestre [Luiz]
- Determinar o endpoint de remoção de disciplina [Willian]
<br />

### **História #6: Como usuário, eu gostaria de gerar um relatório de desempenho acadêmico geral em um semestre, processando métricas como: tempo de estudo, notas, atividades entregues e pendentes e faltas, de todas as disciplinas** <br />
Tarefas e Responsáveis:
- Criar o dashboard inicial [Luiz]
- Determinar o endpoint que retorna uma lista contendo as atividades entregues e pendentes, por disciplina [Willian]
- Determinar o endpoint que retorna as seguintes métricas, por disciplina: [Vinicius]
  - tempo de estudo
  - notas
  - faltas
<br />

### **História #7: Como usuário, eu gostaria de observar e registrar minhas faltas por disciplina** <br />
Tarefas e Responsáveis:
- Criar o dashboard de horário [Luiz]
- Implementar uma interface que lista as disciplinas do semestre e ofereça a ação de atualizar o número de faltas para cada uma [Vinicius]
- Determinar o endpoint com a lista de disciplinas, faltas, horários e saldo restante [Edson]
<br />

### **História #8: Como usuário, eu gostaria de registrar horários de estudo por disciplina** <br />
Tarefas e Responsáveis:
- Criar botão + modal de cadastro de horário de estudo na dashboard de horários [Luiz]
- Determinar o endpoint de cadastro de horário de estudo por disciplina [Willian]
<br />

### **História #9: Como usuário, eu gostaria de acessar a um calendário virtual, o qual eu possa registrar e ser lembrado de datas de avaliações, de entregas de atividades e trabalhos pendentes e dentre outros** <br />
Tarefas e Responsáveis:
- Criar o Dashboard de Calendário [Vinicius]
- Adicionar nova entidade (atividade) no banco de dados [Willian]
- Determinar endpoint que preenche as atividades por data [Edson]
- Criar botão + modal de adicionar atividades [Vinicius]
- Determinar o endpoint para a criação de atividades [Luiz]
- Determinar o endpoint para a arquivação de atividades [Edson]
- Determinar o endpoint para a edição de atividades [Willian]
- Determinar o endpoint para o disparo de lembretes de atividades [Luiz]
<br />

### **Demais histórias:**
- Como usuário, eu gostaria de *acessar a um calendário virtual*, o qual eu possa registrar e ser lembrado de datas de avaliações, de entregas de atividades e trabalhos pendentes e dentre outros; <br />
- Como usuário, eu gostaria de acessar a um boletim virtual, para *registro de notas obtidas por trabalhos, exercícios e provas*; <br />
- Como usuário, eu gostaria de criar e *salvar anotações sobre as aulas e estudos por disciplina*; <br />
- Como usuário, eu gostaria de *criar ou entrar em grupos de estudos* com outros usuários da plataforma; <br />
- Como usuário, eu gostaria de *compartilhar arquivos* com outros usuários da plataforma; <br />
- Como usuário, eu gostaria de *entrar em contato com outros usuários* da plataforma; <br />




# **Prototipação no Figma**
### **Link:** 
https://www.figma.com/file/7ET3V7yJVB9xxx3OTjkg7T/StudyMember?type=design&node-id=0%3A1&mode=design&t=KnMwpeGiYRqYocx7-1
<br />

###  **Telas:**
![StudyMember-1](https://github.com/edjunio25/TP_PDS/assets/55067918/e14bef3c-0b0b-4780-9395-bfe491a2c964)
![StudyMember-2](https://github.com/edjunio25/TP_PDS/assets/55067918/5b7d4139-9758-493e-b1df-be73fe2937c7)
![StudyMember-3](https://github.com/edjunio25/TP_PDS/assets/55067918/a9201821-520c-42e0-abd9-d86d95eb1aa4)
![StudyMember-4](https://github.com/edjunio25/TP_PDS/assets/55067918/cff88144-0789-41ef-aea1-4023a4c327c7)
![StudyMember-5](https://github.com/edjunio25/TP_PDS/assets/55067918/a98c4a02-1d53-48f5-b5d6-911357b6cf1b)
![StudyMember-6](https://github.com/edjunio25/TP_PDS/assets/55067918/ecad3f1d-9df6-4442-8951-f52142f518b7)
