/*function form() {
    if(header.click) {
        console.log("clicou");
    }else {
        console.log("Não clicou");
    }

    return 1;
}*/

//Quando dentro de um Objeto This tem sua referencia//vai se 
//referir ao objeto em si
const pessoa = {
    firstName: 'Diego',
    lastName: 'Vieira',
    getFullName: function () {
        console.log(`${this.firstName} ${this.lastName}`);
    },

    //pessoa.getFullName(); -> Da o nome por inteiro
}



//Como This está sozinho, o mesmo puxa o Objeto Global 
//Neste caso em navegadores a propia "window"
console.log(this);

//Como this está em uma função a referencia é o Objeto Global
(function(){
    console.log(this);
})();

//Quando em um Evento this tem como referencia o Elemento
//que recebeu o Evento

/*
<!DOCTYPE html>

<html>
    <head>
        <title>Documento Exemplo de evento</title>
    </head>
    <body>
        <button
        id="my-btn"
        onclick="console.log(this)">
            click in
        </button>
    </body>
</html>
*/

//Manipulando valores

    //Metodo Call -> Dita o que deseja se referir

const pessoa2 = {
    nome: 'Miguel',
};

const animal = {
    nome: 'Murphy',
};

function getSomething() {
    console.log(this.nome);
}

//getSomething.call("Objeto Desejado de retorno"); --->

getSomething.call(pessoa2);
getSomething.call(animal);