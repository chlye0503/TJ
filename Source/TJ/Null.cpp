// Fill out your copyright notice in the Description page of Project Settings.


#include "Null.h"

// Sets default values
ANull::ANull()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ANull::BeginPlay()
{
	Super::BeginPlay();

	//UE_LOG(LogTemp, Error, TEXT("Test"));
	
}

// Called every frame
void ANull::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}


