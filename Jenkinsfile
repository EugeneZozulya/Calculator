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
                bat "dotnet restore ${workspace}\\Calculator\\Calculator.sln"
            }
        }      
        stage('Clean') {
            steps {
                bat "dotnet clean ${workspace}\\Calculator\\Calculator.sln --configuration Release"
            }
        }
        stage('Build') {
            steps {
            bat "dotnet build ${workspace}\\Calculator\\Calculator.sln --configuration Release"
            }
        }
        stage('Running unit tests') {
            steps {
                bat "dotnet test ${workspace}/Calculator/CalculatorTest/CalculatorTest.csproj "         
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