export class QuestionBank{
    questions:any;
    totalQuestions:number = 5;
    selectedQuestions =[];
    options= [];
    answers =[];
    constructor(){       
        this.questions = [
            {
                id: 1, title: "Who is the richest man in the World?",
                options: [{ id: 'a', title: 'Warren Buffet' }, { id: 'b', title: 'Bill Gates' },
                { id: 'c', title: 'Jeff Bezos' }, { id: 'd', title: 'Mark Zuckerberg' }],
                answer: 'c'
            },
            {
                id: 2, title: "Who is the highest Run Scorer in Cricket World?",
                options: [{ id: 'a', title: 'Ricky Ponting' }, { id: 'b', title: 'Sachin Tendulkar' },
                { id: 'c', title: 'Saurav Ganguly' }, { id: 'd', title: 'Brian Lara' }],
                answer: 'b'
            },
            {
                id: 3, title: "Which is the largest country in the World?",
                options: [{ id: 'a', title: 'Russia' }, { id: 'b', title: 'Canada' },
                { id: 'c', title: 'USA' }, { id: 'd', title: 'China' }],
                answer: 'a'
            },
            {
                id: 4, title: "Which is the satellite of the Planet  Earth?",
                options: [{ id: 'a', title: 'Titan' }, { id: 'b', title: 'Moon' },
                { id: 'c', title: 'Exodus' }, { id: 'd', title: 'Venus' }],
                answer: 'b'
            },
            {
                id: 5, title: "When is the Independence Day of India?",
                options: [{ id: 'a', title: '4th,July' }, { id: 'b', title: '15th,August' },
                { id: 'c', title: '1st,May' }, { id: 'd', title: '26th, January' }],
                answer: 'b'
            },
            {
                id: 6, title: "What is the Capital of Portugal?",
                options: [{ id: 'a', title: 'Madrid' }, { id: 'b', title: 'Lisbon' },
                { id: 'c', title: 'New York' }, { id: 'd', title: 'Cape Town' }],
                answer: 'b'
            },
            {
                id: 7, title: "Which is the highest mountain?",
                options: [{ id: 'a', title: 'Mt. Everest' }, { id: 'b', title: 'Kanchenjunga' },
                { id: 'c', title: 'Nanda Devi' }, { id: 'd', title: 'Lhotse' }],
                answer: 'a'
            },
            {
                id: 8, title: "What is the value of PI?",
                options: [{ id: 'a', title: '22/9' }, { id: 'b', title: '3.14' },
                { id: 'c', title: '11.22' }, { id: 'd', title: '4.98' }],
                answer: 'b'
            },
            {
                id: 9, title: "Who has won the Most Grand Slams in Female Tennis?",
                options: [{ id: 'a', title: 'Maria Sharapova' }, { id: 'b', title: 'Serena Willams' },
                { id: 'c', title: 'Steffi Graf' }, { id: 'd', title: 'Maragaret Court' }],
                answer: 'd'
            },
            {
                id: 10, title: "Which organisation has the highest market value?",
                options: [{ id: 'a', title: 'Google' }, { id: 'b', title: 'Microsoft' },
                { id: 'c', title: 'Apple' }, { id: 'd', title: 'Amazon' }],
                answer: 'c'
            }
        ]; 
    }

    initializeQuestions() {
        var j = 1, k = 1;
        var randomNumber = Math.floor(Math.random() * 10);
        var startIndex;
        var endIndex;
        if (randomNumber + this.totalQuestions > 9) {
            startIndex = randomNumber - this.totalQuestions;
            endIndex = randomNumber
        }
        else {
            startIndex = randomNumber;
            endIndex = randomNumber + this.totalQuestions;
        }
        for (let i = startIndex; i < endIndex; i++) {
            this.selectedQuestions.push([i,this.questions[i].title]);
            var optionsi = document.createElement('div');;
            for (var option of this.questions[i].options) {
                this.options.push([i,this.questions[i].options])
            }
            j++;
            k++;
        }
        return this.selectedQuestions;
    }

    getOptions(){
        return this.options;
    } 
}

