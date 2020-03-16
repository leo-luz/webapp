pipeline {
    agent any
    stages{
        stage('Clean Workspace'){
            steps{
                 cleanWs()
            }
        }
        stage('Checkout do código GitHUB'){
            steps{
                /*git 'https://github.com/leo-luz/webapp.git'*/
                git url: 'git@github.com:leo-luz/webapp.git', credentialsId: 'GitHub'
            }
        }
        stage('Restore das dependênias'){
            steps{
                bat 'dotnet restore'
            }
        }
        stage('Build'){
            /*steps{
                bat 'dotnet build'
            }*/
            steps{
                withSonarQubeEnv('SonarServer'){
                    bat "dotnet sonarscanner begin /k:webAPP"
                    bat 'dotnet build'
                    bat "dotnet sonarscanner end"
                }   
            }
        }
    }
    /*post{
        always{
           
        }
    }*/
}