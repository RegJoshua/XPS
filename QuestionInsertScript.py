class Question:

    def __init__(self):
        self.QuestionID = 0
        self.Citation = ''
        self.Text = ''
        self.CorrectAnswer = ''
        self.IncorrectAnswers = []
        self.Category = 0
        self.Condition = ''
        self.ImagePath = ''

    def GenerateInsertStatement(self):
        result = ''

        result += 'INSERT INTO Question(\n'
        result += 'QuestionID\n'
        result += ', QuestionText\n'
        result += ', CorrectAnswer\n'

        for i in range(len(self.IncorrectAnswers)):
            result += ', IncorrectAnswer' + str(i + 1) + '\n'

        result += ', Category\n'
        result += ', ImageName\n'
        result += ', Citation\n'
        result += ', Paragraph)\n'
        result += 'VALUES (\n'
        result += str(self.QuestionID) + '\n'
        result += ', \'' + self.Text + '\'\n'
        result += ', \'' + self.CorrectAnswer + '\'\n' 
        
        for s in self.IncorrectAnswers:
            result += ', \'' + s + '\'\n'

        result += ', ' + str(self.Category) + '\n'
        result += ', \'' + self.ImagePath + '\'\n'
        result += ', \'' + self.Citation + '\'\n'
        result += ', \'' + self.Condition + '\'\n'
        result += ');' 

        return result

f = open('C:\\Users\\Mason\\Documents\\Python Scripts\\Python\\XPS\\Questions.txt', 'r')
Questions = []

for i in range(75):
    print('# Question ' + str(i + 1))
    line = ''
    q = Question()

    while(not line.startswith('end')):

        if(line.startswith('k ')):
            q.QuestionID = int(line[2: ])
        if(line.startswith('cit ')):
            q.Citation = line[4: ].replace('\n', '')
        if(line.startswith('ctg ')):
            q.Category = int(line[4: ])
        if(line.startswith('q ')):
            q.Text = line[2: ].replace('\n', '')
        if(line.startswith('aa ')):
            q.CorrectAnswer = line[3: ].replace('\n', '')
        if(line.startswith('af ')):
            q.IncorrectAnswers.append(line[3: ].replace('\n', ''))

        line = f.readline()
        line.replace('\n', '')

    Questions.append(q)


for q in Questions:
    print(q.GenerateInsertStatement())
