pipeline {
    agent any
    stages {
        stage ('Clean workspace') {
            steps {
                cleanWs()
            }
        } 
        stage ('Git Checkout') {
            steps {
                git branch: 'main', credentialsId: '16a84b04-d65d-4959-8667-389a2c3e3893', url: 'https://github.com/EugeneZozulya/Calculator.git'
            }
        }
        stage('Restore packages') {
            steps {
                bat "dotnet restore ${workspace}\\Calculator.sln"
            }
        }      
        stage('Clean') {
            steps {
                bat "dotnet clean ${workspace}\\Calculator.sln --configuration Release"
            }
        }
        stage('Build') {
            steps {
            bat "dotnet build ${workspace}\\Calculator.sln --configuration Release"
            }
        }
        stage('Running unit tests') {
            steps {
                bat "dotnet add ${workspace}/CalculatorTest/CalculatorTest.csproj package JUnitTestLogger --version 1.1.0"
                bat "dotnet test ${workspace}/CalculatorTest/CalculatorTest.csproj --logger \"junit;LogFilePath=\"${WORKSPACE}\"/TestResults/1.0.0.\"${env.BUILD_NUMBER}\"/results.xml\" --configuration release --collect \"Code coverage\""         
            }        
        }
    }
 }