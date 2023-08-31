pipeline{
    agent any
    environment {
        DIRECTORY_PATH = "${workspace}"
        TESTING_ENVIRONMENT = "Jackson Project"
        PRODUCTION_ENVIRONMENT = "Jackson"
    }
    stages {
        stage('Build'){
            steps{
                echo "fetch the source code from the directory path specified: ${env.DIRECTORY_PATH}"
                echo "compile the code and generate any necessary artifacts"
            }
        }
        stage('Test'){
            steps{
                echo "unit tests"
                echo "integration tests"
            }
        }

        stage('CodeQualityCeck'){
            steps{
                echo "check the quality of the code"
            }
        }
        stage('Deploy'){
            steps{
                echo "deploy the application to a testing environment specified: ${env.TESTING_ENVIRONMENT}"

            }
        }
        stage('Approval'){
            steps{
                sleep 10
            }
        }
        stage('DeployToProduction'){
            steps{
                echo "Deploying the code to production environment: ${env.PRODUCTION_ENVIRONMENT}"
            }
        }
    }

}