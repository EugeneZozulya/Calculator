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
                git branch: 'main', credentialsId: 'a19259f1-fbaa-437c-b905-f8d3e48bc20a', url: 'https://github.com/EugeneZozulya/Calculator.git'
            }
        }
        stage('Restore packages') {
            steps {
                bat "dotnet restore ${workspace}\\Calculator_main\\Calculator.sln"
            }
        }      
        stage('Clean') {
            steps {
                bat "dotnet clean ${workspace}\\Calculator_main\\Calculator.sln --configuration Release"
            }
        }
        stage('Build') {
            steps {
            bat "dotnet build ${workspace}\\Calculator_main\\Calculator.sln --configuration Release"
            }
        }
        stage('Running unit tests') {
            steps {
                bat "dotnet add ${workspace}/Calculator_main/CalculatorTest/CalculatorTest.csproj package JUnitTestLogger --version 1.1.0"
                bat "dotnet test ${workspace}/Calculator_main/CalculatorTest/CalculatorTest.csproj --logger \"junit;LogFilePath=\"${WORKSPACE}\"/TestResults/1.0.0.\"${env.BUILD_NUMBER}\"/results.xml\" --configuration release --collect \"Code coverage\""         
            }        
        }
    }
    post {
        always {
            archiveArtifacts artifacts: '**/*.msix', followSymlinks: false
            junit "TestResults/1.0.0.${env.BUILD_NUMBER}/results.xml"
        }
    }
 }