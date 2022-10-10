# OwlParser

![Current Stage](http://img.shields.io/static/v1?label=STATUS&message=CONCLUÍDO&color=GREEN&style=for-the-badge)
![NET Version](http://img.shields.io/static/v1?label=.NET&message=6.0&color=GREEN&style=for-the-badge)

Biblioteca para converter XML OWL(Web Ontology Language) para BPMN.

## Descrição do projeto
>A OWL (Ontology Web Language) é uma linguagem para definir e instanciar ontologias na World Wide Web.
Uma ontologia OWL pode incluir descrições de classes e suas respectivas propriedades e seus relacionamentos. 
OWL foi projetada para o uso por aplicações que precisam processar o conteúdo da informação ao invés de apenas apresentá-la aos humanos. ([Wikipédia](https://pt.wikipedia.org/wiki/OWL))

Esse projeto foi desenvolvido como o objetivo de converter arquivos OWL em BPMN(Business Process Model And Notation Document).
Esse arquivo poderá ser posteriormente importado no software [Bizagi](https://www.bizagi.com) e gerado um diagrama dos processos.


## Executando

O projeto pode ser executado utilizando o comando:

```bash
# .NET 6.0 é requerido
$ dotnet run -p OwlParser.API
```

## Contribuição
Fique a vontade para clonar, testar e realizar melhorias 😉
